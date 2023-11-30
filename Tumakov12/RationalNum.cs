namespace Tumakov12
{
    class RationalNum
    {
        readonly int chislitel;
        readonly int denominator;

        public static RationalNum MakeRationalNum(int chislitel, int denominator)
        {
            if (denominator > 0)
            {
                return new RationalNum(chislitel, denominator);
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            if (denominator == 1)
            {
                return $"{chislitel}";
            }
            else
            {
                return $"{chislitel}/{denominator}";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is RationalNum rationalNum)
            {
                int newDenominator = FindingDenominator(denominator, rationalNum.denominator);
                int newFirstNumerator = chislitel * (newDenominator / denominator);
                int newSecondNumerator = rationalNum.chislitel * (newDenominator / rationalNum.denominator);

                if (newFirstNumerator == newSecondNumerator)
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

        private static int FindingDenominator(int firstDenominator, int secondDenominator)
        {
            int firstNumber = firstDenominator;
            int secondNumber = secondDenominator;

            while ((firstNumber != 0) && (secondNumber != 0))
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber %= secondNumber;
                }
                else
                {
                    secondNumber %= firstNumber;
                }
            }

            return (firstDenominator * secondDenominator) / (firstNumber + secondNumber);
        }

        public static RationalNum operator +(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            int newDenominator = FindingDenominator(firstRationalNumber.denominator, secondRationalNumber.denominator);
            int newNumerator = (firstRationalNumber.chislitel * (newDenominator / firstRationalNumber.denominator)) + (secondRationalNumber.chislitel * (newDenominator / secondRationalNumber.denominator));

            return new RationalNum(newNumerator, newDenominator);
        }

        public static RationalNum operator -(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            int newDenominator = FindingDenominator(firstRationalNumber.denominator, secondRationalNumber.denominator);
            int newNumerator = (firstRationalNumber.chislitel * (newDenominator / firstRationalNumber.denominator)) - (secondRationalNumber.chislitel * (newDenominator / secondRationalNumber.denominator));

            return new RationalNum(newNumerator, newDenominator);
        }

        public static RationalNum operator *(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            return new RationalNum(firstRationalNumber.chislitel * secondRationalNumber.chislitel, firstRationalNumber.denominator * secondRationalNumber.denominator);
        }

        public static RationalNum operator /(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            return new RationalNum(firstRationalNumber.chislitel * secondRationalNumber.denominator, firstRationalNumber.denominator * secondRationalNumber.chislitel);
        }

        public static int operator %(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            RationalNum rationalNumber = firstRationalNumber / secondRationalNumber;

            return (rationalNumber.chislitel % rationalNumber.denominator);
        }

        public static bool operator ==(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            int newDenominator = FindingDenominator(firstRationalNumber.denominator, secondRationalNumber.denominator);
            int newFirstNumerator = firstRationalNumber.chislitel * (newDenominator / firstRationalNumber.denominator);
            int newSecondNumerator = secondRationalNumber.chislitel * (newDenominator / secondRationalNumber.denominator);

            return newFirstNumerator == newSecondNumerator;
        }

        public static bool operator !=(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            int newDenominator = FindingDenominator(firstRationalNumber.denominator, secondRationalNumber.denominator);
            int newFirstNumerator = firstRationalNumber.chislitel * (newDenominator / firstRationalNumber.denominator);
            int newSecondNumerator = secondRationalNumber.chislitel * (newDenominator / secondRationalNumber.denominator);

            return newFirstNumerator != newSecondNumerator;
        }

        public static bool operator >(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            int newDenominator = FindingDenominator(firstRationalNumber.denominator, secondRationalNumber.denominator);
            int newFirstNumerator = firstRationalNumber.chislitel * (newDenominator / firstRationalNumber.denominator);
            int newSecondNumerator = secondRationalNumber.chislitel * (newDenominator / secondRationalNumber.denominator);

            return newFirstNumerator > newSecondNumerator;
        }

        public static bool operator <(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            int newDenominator = FindingDenominator(firstRationalNumber.denominator, secondRationalNumber.denominator);
            int newFirstNumerator = firstRationalNumber.chislitel * (newDenominator / firstRationalNumber.denominator);
            int newSecondNumerator = secondRationalNumber.chislitel * (newDenominator / secondRationalNumber.denominator);

            return newFirstNumerator < newSecondNumerator;
        }

        public static bool operator >=(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            int newDenominator = FindingDenominator(firstRationalNumber.denominator, secondRationalNumber.denominator);
            int newFirstNumerator = firstRationalNumber.chislitel * (newDenominator / firstRationalNumber.denominator);
            int newSecondNumerator = secondRationalNumber.chislitel * (newDenominator / secondRationalNumber.denominator);

            return newFirstNumerator >= newSecondNumerator;
        }

        public static bool operator <=(RationalNum firstRationalNumber, RationalNum secondRationalNumber)
        {
            int newDenominator = FindingDenominator(firstRationalNumber.denominator, secondRationalNumber.denominator);
            int newFirstNumerator = firstRationalNumber.chislitel * (newDenominator / firstRationalNumber.denominator);
            int newSecondNumerator = secondRationalNumber.chislitel * (newDenominator / secondRationalNumber.denominator);

            return newFirstNumerator <= newSecondNumerator;
        }

        public static RationalNum operator ++(RationalNum rationalNumber)
        {
            return new RationalNum(rationalNumber.chislitel + rationalNumber.denominator, rationalNumber.denominator);
        }

        public static RationalNum operator --(RationalNum rationalNumber)
        {
            return new RationalNum(rationalNumber.chislitel - rationalNumber.denominator, rationalNumber.denominator);
        }

        public static explicit operator float(RationalNum rationalNumber)
        {
            return (float)rationalNumber.chislitel / rationalNumber.denominator;
        }

        public static explicit operator int(RationalNum rationalNumber)
        {
            return rationalNumber.chislitel / rationalNumber.denominator;
        }

        private RationalNum(int numerator, int denominator)
        {
            this.chislitel = numerator;
            this.denominator = denominator;
        }
    }
}
