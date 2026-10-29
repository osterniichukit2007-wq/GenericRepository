
namespace GenericRepository
{
    public class Posting : Model
    {
        public string TrackingNumber { get; set; } = "";
        public double Weight { get; set; }
        public string SenderAddress { get; set; } = "";
        public string ReceiverAddress { get; set; } = "";
        public string Status { get; set; } = "";
    }
}