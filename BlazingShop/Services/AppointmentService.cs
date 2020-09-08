using System.Collections.Generic;
using System.Linq;
using BlazingShop.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Services
{
    public class AppointmentService
    {
        private readonly ApplicationDbContext _dbContext;
        public AppointmentService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateAppointment(Appointment appointment)
        {
            //appointment.ProductId = appointment.Product.Id;

            _dbContext.Appointments.Add(appointment);
            return _dbContext.SaveChanges() >= 0;
        }

        public List<Appointment> GetAppointments()
        {
            return _dbContext.Appointments.Include(a => a.Product).ToList();
        }

        public Appointment GetAppointment(int appointmentId)
        {
            return _dbContext.Appointments.FirstOrDefault(a => a.Id == appointmentId);
        }

        public bool ConfirmAppointment(Appointment appointment)
        {
            var dbAppointment = _dbContext.Appointments.Find(appointment.Id);

            if (dbAppointment != null)
            {
                dbAppointment.AppointmentDate = appointment.AppointmentDate;
                dbAppointment.CustomerName = appointment.CustomerName ?? dbAppointment.CustomerName;
                dbAppointment.CustomerPhone = appointment.CustomerPhone ?? dbAppointment.CustomerPhone;
                dbAppointment.CustomerEmail = appointment.CustomerEmail ?? dbAppointment.CustomerEmail;

                appointment.IsConfirmed = true;  // Note! Always true
                return _dbContext.SaveChanges() >= 0;
            }
            return false;
        }

        public bool DeleteAppointment(int appointmentId)
        {
            var appointment = _dbContext.Appointments.Find(appointmentId);
            if (appointment != null)
            {
                _dbContext.Appointments.Remove(appointment);
                return _dbContext.SaveChanges() >= 0;
            }
            return false;
        }

    }
}