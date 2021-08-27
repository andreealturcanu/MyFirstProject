using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BusinessLogic.Models;
using DataAccessLayer.Entities;

namespace BusinessLogic.Mapper
{
    public class MapFromModelToEntity: Profile
    {
        public MapFromModelToEntity()
        {
            CreateMap<ToDoItemModel, ToDoItem>();
        }
    }
}
