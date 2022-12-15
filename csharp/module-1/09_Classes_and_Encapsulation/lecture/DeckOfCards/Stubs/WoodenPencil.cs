using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing; //adds the concept of colors

namespace DeckOfCards.Stubs
{
    //Namespace definition
    //uppercase with a module or general purpose it provides
    //seperated by periods
    
    
    //Class declaration
    //PascalCase
    
    public class WoodenPencil

        //access modifier is private by default
        //public to access it in other places
    {
        //class variables and properties

        //static modified or const
        //public or private

        //fixed or set default val for length, shape, hardness, and color
        //external code should ask for defaults

        //all pencils have minimum length before they are a stub

        //pencils have minimum sharpness before they need to be sharpened

        //values belong to "ALL" wooden pencils

        //CLASS VARIABLES
        //public: other classes and methods have access, shared outside this class
        //const: ensures these variable values wont change
        public const double DefaultLength = 8.0;
        public const int DefaultShape = 2;
        public const string DefaultHardness = "HB";
        public static readonly Color DefaultColor = Color.Yellow;
        //color cant be const, its derived from system.Drawing
        //static: shared among class, not individual variables (pencils), data and behaviors are on class, not object
        //readonly: cannot be altered outside of the class once set, cannot change
        public const double DefaultStubLenght = 2.0;
        public const double DefaultMaxDullness = 0.3;

        private static double stubLength = DefaultStubLenght; //when a pencil is considered a stub in inches
        //private: only accessible inside the class
        //access modifiers: public vs private

        /// <summary>
        //Object variables
        /// </summary>
        public double Length { get; set; }


    }
}
