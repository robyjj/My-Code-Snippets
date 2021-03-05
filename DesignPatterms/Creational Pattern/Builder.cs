namespace DesignPatterns.Creational_Pattern
{
    /*
        Need to create an object in several steps (a step by step approach).

        The creation of objects should be independent of the way the object's parts are assembled.
    
        Runtime control over the creation process is required.
    */
    public interface IToyBuilder
    {
        void SetModel();
        void SetHead();
        void SetLimbs();
        void SetBody();
        void SetLegs();
        Toy GetToy();
    }

    public class Toy
    {
        public string Model
        {
            get;
            set;
        }
        public string Head
        {
            get;
            set;
        }
        public string Limbs
        {
            get;
            set;
        }
        public string Body
        {
            get;
            set;
        }
        public string Legs
        {
            get;
            set;
        }
    }

    //Concreate Builder 
    public class ToyABuilder:IToyBuilder
    {
        Toy toy = new Toy();
        public void SetModel()
        {
            toy.Model = "TOY A";
        }
        public void SetHead()
        {
            toy.Head = "1";
        }
        public void SetLimbs()
        {
            toy.Limbs = "4";
        }
        public void SetBody()
        {
            toy.Body = "Plastic";
        }
        public void SetLegs()
        {
            toy.Legs = "2";
        }
        public Toy GetToy()
        {
            return toy;
        }

    } 

    //Director class
    public class ToyCreator
    {
        private IToyBuilder _toyBuilder;
        public ToyCreator(IToyBuilder toyBuilder)
        {
            _toyBuilder = toyBuilder;
        }
        public void CreateToy()
        {
            _toyBuilder.SetModel();
            _toyBuilder.SetHead();
            _toyBuilder.SetLimbs();
            _toyBuilder.SetBody();
            _toyBuilder.SetLegs();
        }

        public void GetToy()
        {
            _toyBuilder.GetToy();
        }
    }

    public class Client
    {
        public void RunBuilder()
        {
            ToyCreator toyA = new ToyCreator(new ToyABuilder());
            toyA.CreateToy();
            toyA.GetToy();
        }
    }

}
