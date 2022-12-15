namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public abstract class FarmAnimal : ISingable
    {
        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; }

        private string sound;
        /// <summary>
        /// The farm animal's sound.
        /// </summary>
        public virtual string Sound
            //virtual: allows children to override this property in their class
        {
            get
            {
                if (isAsleep)
                {
                    return "Zzz...";
                }
                return sound;
            }
            set
            {
                sound = value;
            }
        }

        //
        public bool isAsleep { get; private set; }

        

        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        /// <param name="sound">The sound that the animal makes.</param>
        public FarmAnimal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        //making the animal take a nap
        public void Sleep(bool isAsleep)
        {
            this.isAsleep = isAsleep;
        }

        //make the animal eat
        //abstract method inside abstract class
        public abstract string Eat();
        
    }
}
