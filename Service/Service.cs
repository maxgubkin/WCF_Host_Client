using System.ServiceModel;
using Contract;



namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class MyService : IContract
    {
        public double Divide(double divident, double divisor)
        {
            return divident / divisor;
        }
    }
}
