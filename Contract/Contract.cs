using System.ServiceModel;




namespace Contract
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        double Divide(double divident, double divisor);
    }
}
