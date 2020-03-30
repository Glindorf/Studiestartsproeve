namespace Sandbox
{
    public class Person
    {
        #region Instance fields

        private string _name;

        private int _age;

        private int _telephoneNumber;

        #endregion


        #region Constructor

        public Person(string name, int age, int telephoneNumber)
        {
            _name = name;
            _age = age;
            _telephoneNumber = telephoneNumber;
        }

        #endregion
        
        
        #region Properties

        public string Name 
        {
            get { return _name; }
        }

        public int Age 
        {
            get { return _age; }
        }

        public int TelephoneNumber 
        {
            get { return _telephoneNumber; }
        }

        #endregion

        #region Methods

        public void IncreaseAge()
        {
            _age = _age +1;
        }
        #endregion
    }
}