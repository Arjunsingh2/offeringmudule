﻿using IPTreatmentOffering.Model;
using IPTreatmentOffering.Provider;
using IPTreatmentOffering.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace IPTreatmentOffering.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OfferingController : ControllerBase
    {

        private readonly TreatmentContext context;
        private readonly SpecialistRepo srepo = new SpecialistRepo();
        private readonly TreatmentPackageRepo tprepo = new TreatmentPackageRepo();
        public OfferingController(TreatmentContext context)
        {
            this.context = context;
            if (!context.Specialists.Any())
            {
                srepo.Addspecialist(context);
                context.SaveChanges();
            }
            if (!context.TreatmentPackages.Any())
            {
                tprepo.AddTreatmentPackage(context);
                context.SaveChanges();
            }
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetSpecialist()
        {

            return Ok(context.Specialists.ToList());
        }

        [HttpGet]
        public IActionResult GetPackage()
        {
            return Ok(context.TreatmentPackages.ToList());
        }
        [HttpGet("{ailment}/{design}")]
        public IActionResult GetSpecialisttype(string ailment, string design)
        {
            Specialist spec=new();
            try
            {
                spec = context.Specialists.Where(p => p.AreaOfExpertise == ailment && p.Designation == design && p.Status == "Available").FirstOrDefault();
                spec.Status = "Busy";
                context.SaveChanges();
                return Ok(spec);
            }

            catch (Exception)
            {
                return NotFound("Specialist Not Available");
            }


        }
        [HttpGet("{ailment}/{package}")]
        public IActionResult GetPackagetype(string ailment, string package)
        {
            return Ok(context.TreatmentPackages.Where(p => p.Ailment == ailment && p.Package == package).FirstOrDefault());
        }
        [HttpGet("{id}")]
        [Authorize]
        public IActionResult MarkAvailable(int id)
        {
            Specialist specialist = context.Specialists.Where(p => p.Id == id).FirstOrDefault();
            specialist.Status = "Available";
            context.SaveChanges();
            return Ok();
        }

    }
}
