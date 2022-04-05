using eModal.IService;
using eModal.Request;
using eModal.Models;
namespace eModal.Service
{
    public class AppointmentService: IAppointmentService
    {
        private readonly MainContext _context;
        public AppointmentService(MainContext context)
        {
            _context = context;
        }
        //GET
        public async Task<IResult> GetAppointments()
        {
            return Results.Ok(await _context.Appointments.ToListAsync());
        }
        //GET {id}
        public async Task<IResult> GetAppointment(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            return appointment != null ? Results.Ok(appointment) : Results.NotFound();
        }
        //POST
        public async Task<IResult> CreateAppointment(AppointmentRequest appointment)
        {
            var createAppointment = _context.Appointments.Add(new Appointment
            {
                Appointment_id=appointment.Appointment_id,
                User_id= appointment.User_id,
                Container_id=appointment.Container_id,
                Pickup_date= appointment.Pickup_date,
                Sending_date= appointment.Sending_date,
                Source_terminal_id= appointment.Source_terminal_id,
                Delivery_terminal_id= appointment.Delivery_terminal_id,
                Delivery_id= appointment.Delivery_id,
                User_remarks= appointment.User_remarks,
                Cost= appointment.Cost,
                Terminal_remarks= appointment.Terminal_remarks,
                Datetime= appointment.Datetime,
                Receiver_fullname= appointment.Receiver_fullname,
                Receiver_phone= appointment.Receiver_phone,
                Receiver_mail= appointment.Receiver_mail,
                Appointment_status= appointment.Appointment_status,
                Request_response_date= appointment.Request_response_date,
                Payment_id= appointment.Payment_id,
                Payment_date= appointment.Payment_date
            });
            await _context.SaveChangesAsync();
            return Results.Created($"/appointment/" +
                $"{createAppointment.Entity.Id}", createAppointment.Entity);
        }
        //PUT
        public async Task<IResult> UpdateAppointment(int id, AppointmentRequest appointment)
        {
            var appointmentToUpdate = await _context.Appointments.FindAsync(id);
            if (appointmentToUpdate == null)
            {
                return Results.NotFound();
            }
            appointmentToUpdate.Appointment_id = appointment.Appointment_id;
            appointmentToUpdate.User_id = appointment.User_id;
            appointmentToUpdate.Container_id = appointment.Container_id;
            appointmentToUpdate.Pickup_date = appointment.Pickup_date;
            appointmentToUpdate.Sending_date = appointment.Sending_date;
            appointmentToUpdate.Source_terminal_id = appointment.Source_terminal_id;
            appointmentToUpdate.Delivery_terminal_id = appointment.Delivery_terminal_id;
            appointmentToUpdate.Delivery_id = appointment.Delivery_id;
            appointmentToUpdate.User_remarks = appointment.User_remarks;
            appointmentToUpdate.Cost = appointment.Cost;
            appointmentToUpdate.Terminal_remarks = appointment.Terminal_remarks;
            appointmentToUpdate.Datetime = appointment.Datetime;
            appointmentToUpdate.Receiver_fullname = appointment.Receiver_fullname;
            appointmentToUpdate.Receiver_phone = appointment.Receiver_phone;
            appointmentToUpdate.Receiver_mail = appointment.Receiver_mail;
            appointmentToUpdate.Appointment_status = appointment.Appointment_status;
            appointmentToUpdate.Request_response_date = appointment.Request_response_date;
            appointmentToUpdate.Payment_id = appointment.Payment_id;
            appointmentToUpdate.Payment_date = appointment.Payment_date;
            await _context.SaveChangesAsync();
            return Results.Ok(appointmentToUpdate);
        }
    }
}
