

namespace TestableCodeDemo
{
    public class TestableBusinessClass
    {
        private readonly IDataAccessLayer _layer;

        public TestableBusinessClass(IDataAccessLayer dataAccessLayer)
        {
            _layer = dataAccessLayer;
        }

        public string GetData()
        {
            return _layer.GetData();
        }
    }
}
