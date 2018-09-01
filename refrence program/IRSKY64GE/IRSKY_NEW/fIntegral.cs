/*
 * Created by SharpDevelop.
 * User: Abdurrahman
 * Date: 05/08/2017
 * Time: 22:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IRSKY_NEW
{
	/// <summary>
	/// Description of fIntegral.
	/// </summary>
	public class fIntegral
	{
		const double 
			//	Kalman Filter Const
			Rk = 0.006,
			Qk = 0.001,
			
			// Range Filter Variabel
			lowFilter = -0.8,
			highFilter = 0.8;
			
		double [] logVL = new double[3];
		double
			//	LongTerm Integral Variabel
			vl = 0,
			sl = 0,
			dt = 0,
			
			//	LongTerm Kalman Filter Variabel
			_Xk_1 = 0,
			Pk_1 = 1,
			outKalman = 0,	//	For debugging only
			
			//	Zerogravity Global Variabel
			zGravity = 0;
		
		public double zeroGravity{
			get {
				return zGravity;
			}
			set{
				zGravity = value;
				vl = 0;
				sl = 0;
				
				Pk_1 = 0;
				_Xk_1 = 0;
			}
		}
		
		public fIntegral(double DT)
		{
			dt = DT;
		}
		
		double kalmanFilter(double Zk){
			double _Xk, Kk, Pk;		// Result of Filter
			
			Kk = Pk_1 / (Pk_1 + Rk);
			Pk = (1 - Kk) * (Pk_1 + Qk);
			_Xk = _Xk_1 + Kk * (Zk - _Xk_1);
			
			Pk_1 = Pk;
			_Xk_1 = _Xk;
			
			return _Xk;
		}
		
		public double getKalman(){
			return outKalman;
		}
		
		public double intACC(double acc, bool parasut){
			double ap, vp, sp;

            // Sebelum Separasi (Mode parasut OFF)
            if (!parasut)
            {
                //	Zero Gravity Filter
                ap = acc - zGravity;

                //	Range Filter
                if (ap > lowFilter && ap < highFilter)
                    ap = 0.0;

                //	Kalman Filter
                ap = kalmanFilter(ap);
                outKalman = ap;

                // INTEGRAL KECEPATAN
                vp = vl + (dt * ap);

                logVL[2] = logVL[1];
                logVL[1] = logVL[0];
                logVL[0] = vp;

                //	Jika ada 3 data kecepatan yang sama maka kecepatan 0
                if (vp == logVL[2] && vp == logVL[1])
                    vp = 0;

                //	Jika kecepatan kurang dari 0 maka 0
                if (vp < 0)
                    vp = 0;

                //	INTEGRAL JARAK
                sp = sl + (vl * dt) + (1 / 2 * ap * dt * dt);

                // Jika data sekarang lebih kecil dari data sebelumnya maka data sekarang = sl
                if (sp < sl)
                    sp = sl;

            }else{  //Setelah Separasi (Mode Parasut ON)
                // Kalman Filter
                ap = kalmanFilter(acc);

                //Integral I
                vp = vl - ap * dt;

                //Integral II
                sp = sl + (vl * dt) - (1 / 2 * ap * dt * dt);
            }

            sl = sp;
            vl = vp;

            return sp;
		}
		
		public double getDist(){
            return sl;
		}
	}
}