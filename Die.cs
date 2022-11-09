using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieGAme
{
    internal class Die
    { ///private member fields
        private int _sides;
        private int _faceValue;

        //public Accessors and Mutators
        public int Sides
        { 
            get { return _sides; }
            set
            {
                if (value >= 4)
                {
                    _sides = value;
                }
                else
                {
                    throw new Exception("Invalid size for a Die.");
                
                }
            }
        }//end of sides
        public int FaceValue
        { 
            get { return _faceValue; }
            set
            {
                if (value >= 1)
                {
                    _faceValue = value;
                }
                else
                {
                    throw new Exception("Invalid FAce value");
                }
            }

        
        }//end of FaceVAlue

        ///constructors
        public Die()
        { 
            Sides = 6;
            FaceValue = 1;
        }

        public Die(int sides)
        { 
            Sides=sides;
            FaceValue=1;
        }

        ///class methods  /** this is changing the value, not returning  **/
        public void Roll()
        { 
            Random random = new Random(Guid.NewGuid().GetHashCode()); //*** this is TRUE random****//
            FaceValue = random.Next(1, Sides+1); 
        }//end of Roll

        public int AddDie(Die die2)
        {
            return FaceValue + die2.FaceValue;   
        }//end of AddDie
        




    }
}
