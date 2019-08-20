using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class ComplexNumber
    {
        #region Fields
        private readonly double real;
        private readonly double imaginary;
        #endregion
            
        #region Constructor
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        #endregion

        
        #region Methods    
        public static ComplexNumber operator *(ComplexNumber Complex1, ComplexNumber Complex2)
        {
            return new ComplexNumber(Complex1.real * Complex2.real - Complex1.imaginary * Complex2.imaginary, 
                Complex1.real * Complex2.imaginary + Complex1.imaginary * Complex2.real);
        }

        public static ComplexNumber operator /(ComplexNumber C1, ComplexNumber C2)
        {
            if (C2.real == 0 && C2.imaginary == 0)
                return null;
            return new ComplexNumber((C1.real * C2.real + C1.imaginary * C2.imaginary)
                /(C2.real * C2.real + C2.imaginary*C2.imaginary), 
                (C1.imaginary * C2.real - C1.real * C2.imaginary)
                / (C2.real * C2.real + C2.imaginary * C2.imaginary));
        }

        public void Print()
        {
            if (this.imaginary >= 0)
                Console.WriteLine(this.real + " + " + this.imaginary + "i");
            else
                Console.WriteLine(this.real + " " + this.imaginary + "i"); 
        }
        #endregion
    }
}
 
