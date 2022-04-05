global using Microsoft.EntityFrameworkCore;
using eModal;
using eModal.Models;
using eModal.Service;
using eModal.IService;
using eModal.Request;

var builder = WebApplication.CreateBuilder(args);

//Connection
builder.Services.AddDbContext<MainContext>(option=>option.UseSqlServer
    (builder.Configuration.GetConnectionString("MainContext")));

//Scopes
builder.Services.AddScoped<IAppointmentService, AppointmentService>();
//builder.Services.AddScoped<IContainerTypeDetailService, ContainerTypeDetailService>();

//App Build
var app = builder.Build();

//Appointment
//GET
app.MapGet("/appointment", async (IAppointmentService appointmentService) => await appointmentService.GetAppointments());
//GET {id}
app.MapGet("/appointment/{id}", async (int id,IAppointmentService appointmentService) => await appointmentService.GetAppointment(id));
//PUT
app.MapPut("/appointment/{id}", async (int id,AppointmentRequest appointmentRequest ,IAppointmentService appointmentService) => await appointmentService.UpdateAppointment(id,appointmentRequest));
//POST
app.MapPost("/appointment", async (AppointmentRequest appointmentRequest, IAppointmentService appointmentService) => await appointmentService.CreateAppointment(appointmentRequest));

//ContainerType

app.Urls.Add("http://localhost:3001");
app.Run();
