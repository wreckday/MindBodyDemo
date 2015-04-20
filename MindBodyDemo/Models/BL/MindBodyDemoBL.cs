﻿using MindBodyDemo.AppointmentService;
using MindBodyDemo.Models.DAL;
using MindBodyDemo.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindBodyDemo.Models.BL
{
    public class MindBodyDemoBL : IMindBodyDemoBL
    {
        IMindBodyDemoDal dal;

        public MindBodyDemoBL()
        {
            dal = new MindBodyDemoDal();
        }

        public IEnumerable<MindBodyDemo.StaffService.Staff> GetCompanyStaff()
        {
            return dal.GetAllStaff();
        }

        public List<MindBodyDemo.Models.Data.Appointment> GetStaffAppointments(String first, String lastName, String staffId)
        {
            return dal.GetStaffAppointments( first,  lastName,  staffId);
        }

        public MindBodyDemo.StaffService.Staff GetStaffInfo(string id)
        {
            long pid = Convert.ToInt64(id);
            var staff = GetCompanyStaff();
            MindBodyDemo.StaffService.Staff staffInfo = staff.Single(s => s.ID == pid);
            return staffInfo;
        }
    }
}