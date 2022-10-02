﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IViewComponentResult Invoke()
        {
            var values = skillManager.GetList();
            return View(values);
        }
    }
}
