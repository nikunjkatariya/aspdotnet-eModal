using System.ComponentModel.DataAnnotations;

namespace eModal.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        [Required]
        public string Appointment_id { get; set; }
        [Required]
        public string? User_id { get; set; }
        public string? Container_id { get; set; }
        public DateTime? Pickup_date { get; set; }
        public DateTime? Sending_date { get; set; }
        public string? Source_terminal_id { get; set; }
        public string? Delivery_terminal_id { get; set; }
        public string? Delivery_id { get; set; }
        public string? User_remarks { get; set; }
        public decimal? Cost { get; set; }
        public string? Terminal_remarks { get; set; }
        public DateTime Datetime { get; set; }= DateTime.Now;
        public string? Receiver_fullname { get; set; }
        public string? Receiver_phone { get; set; }
        public string? Receiver_mail { get; set; }
        public string? Appointment_status { get; set; }
        public string? Request_response_date { get; set; }
        public int? Payment_id { get; set; }
        public DateTime? Payment_date { get; set; }
    }
}
