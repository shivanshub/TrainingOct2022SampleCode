namespace TestableCodeDemo
{
    public class NonTestableBusinessClass
    {
        private readonly DataAccessLayer _layer;
        public NonTestableBusinessClass()
        {
            _layer = new DataAccessLayer();
        }

        public string GetData()
        {
            return _layer.GetData();
        }
    }
}
