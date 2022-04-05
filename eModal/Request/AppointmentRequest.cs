namespace eModal.Request
{
    public record AppointmentRequest(string Appointment_id, 
        string? User_id,
        string? Container_id,
        DateTime? Pickup_date,
        DateTime? Sending_date,
        string? Source_terminal_id,
        string? Delivery_terminal_id,
        string? Delivery_id,
        string? User_remarks,
        decimal? Cost,
        string? Terminal_remarks,
        DateTime Datetime,
        string? Receiver_fullname,
        string? Receiver_phone,
        string? Receiver_mail,
        string? Appointment_status,
        string? Request_response_date,
        int? Payment_id,
        DateTime? Payment_date);
}
