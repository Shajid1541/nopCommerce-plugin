using AutoMapper;
using Nop.Plugin.Widget.NopStationEmployees.Domain;
using Nop.Plugin.Widgets.NopStationEmployees.Models;

namespace Nop.Plugin.Widgets.NopStationEmployees.Profiles;
public class ProfileMapping : Profile
{
    public ProfileMapping()
    {
        CreateMap<NopStationEmployee, NopStationEmployeePublicModel>();
    }
}
