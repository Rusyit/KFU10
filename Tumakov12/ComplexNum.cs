namespace Tumakov12
{
    class ComplexNum
    {
        readonly double real;
        readonly double imaginary;

        public static ComplexNum operator +(ComplexNum ComplexNum1, ComplexNum ComplexNum2)
        {
            return new ComplexNum(ComplexNum1.real + ComplexNum2.real, ComplexNum1.imaginary + ComplexNum2.imaginary);
        }

        public static ComplexNum operator -(ComplexNum ComplexNum1, ComplexNum ComplexNum2)
        {
            return new ComplexNum(ComplexNum1.real - ComplexNum2.real, ComplexNum1.imaginary - ComplexNum2.imaginary);
        }

        public static ComplexNum operator *(ComplexNum ComplexNum1, ComplexNum ComplexNum2)
        {
            double newImaginary = ComplexNum1.real * ComplexNum2.imaginary + ComplexNum1.imaginary * ComplexNum2.real;
            double newReal;

            if ((ComplexNum1.imaginary * ComplexNum2.imaginary) > 0)
            {
                newReal = ComplexNum1.real * ComplexNum2.real - (-ComplexNum1.imaginary * ComplexNum2.imaginary);
            }
            else
            {
                newReal = ComplexNum1.real * ComplexNum2.real + (-ComplexNum1.imaginary* ComplexNum2.imaginary);
            }

            return new ComplexNum(newReal, newImaginary);
        }

        public static bool operator ==(ComplexNum ComplexNum1, ComplexNum ComplexNum2)
        {
            return ((ComplexNum1.real == ComplexNum2.real) && (ComplexNum1.imaginary == ComplexNum2.imaginary));
        }

        public static bool operator !=(ComplexNum ComplexNum1, ComplexNum ComplexNum2)
        {
            return ((ComplexNum1.real != ComplexNum2.real) || (ComplexNum1.imaginary != ComplexNum2.imaginary));
        }

        public override bool Equals(object obj)
        {
            if (obj is ComplexNum complexNum)
            {
                if ((real == complexNum.real) && (imaginary == complexNum.imaginary))
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return (imaginary > 0 ? $"({real} + {imaginary}i)" : $"({real} - {-imaginary}i)");
        }

        public ComplexNum(double real, double imaginary)
        {
            this.real = real;
            this.imaginary= imaginary;
        }
    }
}
