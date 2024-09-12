using System;
using AutoMapper;
using BookMyShow_Clone.DTOs.CityDtos;
using BookMyShow_Clone.Models;

namespace BookMyShow_Clone.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<City, CityDto>().ReverseMap();
        // CreateMap<LeaveRequest, LeaveRequestListDto>()
        //     .ForMember(dest => dest.DateRequested, opt => opt.MapFrom(src => src.DateCreated))
        //     .ReverseMap();
        // CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
        // CreateMap<LeaveRequest, UpdateLeaveRequestDto>().ReverseMap();


        // CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        // CreateMap<LeaveAllocation, CreateLeaveAllocationDto>().ReverseMap();
        // CreateMap<LeaveAllocation, UpdateLeaveAllocationDto>().ReverseMap();

        // CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        // CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();
    }
}
