using System;
using SampleSecureWeb.Models;

namespace SampleSecureWeb.Data;

public interface IUser
{
    User Registration(User user);
    User Login (User user);

}