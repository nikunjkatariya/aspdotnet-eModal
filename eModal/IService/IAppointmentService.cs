using eModal.Request;
namespace eModal.IService
{
    public interface IAppointmentService
    {
        Task<IResult> GetAppointments();
        Task<IResult> GetAppointment(int id);
        Task<IResult> CreateAppointment(AppointmentRequest appointment);
        Task<IResult> UpdateAppointment(int id, AppointmentRequest appointment);
    }
}
