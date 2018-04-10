namespace Exercicio4
{
    class ComplexNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        public ComplexNumber()
        {
        }

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public ComplexNumber sum(ComplexNumber sumComplex)
        {
            ComplexNumber newNumber = new ComplexNumber();
            newNumber.RealPart = RealPart + sumComplex.RealPart;
            newNumber.ImaginaryPart = ImaginaryPart + sumComplex.ImaginaryPart;
            return newNumber;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.RealPart + c2.RealPart, c1.ImaginaryPart + c2.ImaginaryPart);
        }

        public ComplexNumber sub(ComplexNumber subComplex)
        {
            ComplexNumber newNumber = new ComplexNumber();
            newNumber.RealPart = RealPart - subComplex.RealPart;
            newNumber.ImaginaryPart = ImaginaryPart - subComplex.ImaginaryPart;
            return newNumber;
        }

        public override string ToString()
        {
            return string.Format("{0}+{1}i", RealPart, ImaginaryPart);
        }
    }
}