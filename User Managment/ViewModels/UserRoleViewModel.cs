using System.Collections.Generic;

namespace User_Managment.ViewModels
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }
}
