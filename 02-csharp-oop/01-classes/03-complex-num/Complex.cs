namespace DSS.N05RefParamsClass
{
    public class Complex
    {

        private int real, img;

        public Complex(int r, int i)
        {
            real = r;
            img = i;
        }

        public int getRealValue()
        {
            return real;
        }

        public int getImgValue()
        {
            return img;
        }

        public static void Update(ref Complex obj)
        {
            obj.real += 5;
            obj.img += 5;
        }
    }
}