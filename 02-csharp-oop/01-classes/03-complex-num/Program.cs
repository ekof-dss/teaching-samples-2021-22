using System;

namespace DSS.N05RefParamsClass
{



    class Program
    {

        static void Main(string[] args)
        {
            Complex cmplx = new Complex(2, 4);
            Console.WriteLine("Complex number {0} =  {1} + i {2}", nameof(cmplx),
                cmplx.getRealValue(), cmplx.getImgValue());

            Complex.Update(ref cmplx);
            Console.WriteLine("After updating {0}", nameof(cmplx) );
            Console.WriteLine("Complex number {0} =  {1} + i {2}", nameof(cmplx),
                cmplx.getRealValue(), cmplx.getImgValue());
        }

    }

}