#pragma checksum "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\Pages\Administration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1569fd6bb24a6b3f392ac1f6ec522545029bbd9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp4s.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\_Imports.razor"
using BlazorApp4s;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\_Imports.razor"
using BlazorApp4s.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\Pages\Administration.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\Pages\Administration.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration")]
    public partial class Administration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Users\mwher\source\repos\BlazorApp4s\BlazorApp4s\Pages\Administration.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    string ADMINISTRATION_ROLE = "Admin";
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    // Property used to add or edit the currently selected user
    IdentityUser TargetUser = new IdentityUser();

    // Tracks the selected role for the currently selected user
    string CurrentUserRole { get; set; } = ""; // from DB
    string SelectedUserRole { get; set; } = ""; // from dropdown

    // Collection to display the existing users
    List<IdentityUser> ColUsers = new List<IdentityUser>();
    // Options to display in the roles dropdown when editing a user
    List<string> Options = new List<string>() { "User", "Admin" };
    // To hold any possible errors
    string strError = "";
    // To enable showing the Popup
    bool ShowPopup = false;

    async Task EditUser(IdentityUser _IdentityUser)
    {
        // Set the selected user
        // as the current user
        TargetUser = _IdentityUser;
        // Get the user
        var user = await _UserManager.FindByIdAsync(TargetUser.Id);
        if (user != null)
        {
            // Is user in administrator role?
            var isAdmin = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (isAdmin)
            {
                CurrentUserRole = ADMINISTRATION_ROLE;
            }
            var isUser = await _UserManager.IsInRoleAsync(user, "User");
            if (isUser)
            {
                CurrentUserRole = "User";
            }
            SelectedUserRole = CurrentUserRole;
        }
        // Open the Popup
        ShowPopup = true;
    }

    async Task DeleteUser()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var user = await _UserManager.FindByIdAsync(TargetUser.Id);
        if (user != null)
        {
            // Delete the user
            await _UserManager.DeleteAsync(user);
        }
        // Refresh Users
        GetUsers();
    }

    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }

    void AddNewUser()
    {
        // Make new user
        TargetUser = new IdentityUser();
        TargetUser.PasswordHash = "*****";
        // Set Id to blank so we know it is a new record
        TargetUser.Id = "";
        // Open the Popup
        ShowPopup = true;
    }

    async Task SaveUser()
    {
        try
        {
            if (SelectedUserRole == "")
            {
                strError = "Select a role";
                return;
            }
            // Is this an existing user?
            if (TargetUser.Id != "")
            {
                // Get the user
                var existingUser = await _UserManager.FindByIdAsync(TargetUser.Id);
                // Update Email
                existingUser.Email = TargetUser.Email;
                // Update the existingUser
                await _UserManager.UpdateAsync(existingUser);
                // Only update password if the current value
                // is not the default value
                if (TargetUser.PasswordHash != "*****")
                {
                    var resetToken = await _UserManager.GeneratePasswordResetTokenAsync(existingUser);
                    var passwordExistingUser = await _UserManager.ResetPasswordAsync(
                            existingUser,
                            resetToken,
                            TargetUser.PasswordHash);
                    if (!passwordExistingUser.Succeeded)
                    {
                        if (passwordExistingUser.Errors.FirstOrDefault() != null)
                        {
                            strError =
                                passwordExistingUser
                                .Errors
                                .FirstOrDefault()
                                .Description;
                        }
                        else
                        {
                            strError = "Password error";
                        }
                        // Keep the popup opened
                        return;
                    }
                }
                // Handle Roles
                if (CurrentUserRole == "")
                {
                    await _UserManager.AddToRoleAsync(existingUser, SelectedUserRole);
                }
                else if (SelectedUserRole != CurrentUserRole)
                {
                    // Is Administrator role selected 
                    // but existingUser is not an Administrator?
                    if ((SelectedUserRole == ADMINISTRATION_ROLE) & (CurrentUserRole != ADMINISTRATION_ROLE))
                    {
                        // remove from old role
                        await _UserManager.RemoveFromRoleAsync(existingUser, CurrentUserRole);
                        // Put admin in Administrator role
                        await _UserManager.AddToRoleAsync(existingUser, ADMINISTRATION_ROLE);
                    }
                    else // when ((SelectedUserRole != ADMINISTRATION_ROLE) & (CurrentUserRole == ADMINISTRATION_ROLE))
                    {
                        // remove from Admin role
                        await _UserManager.RemoveFromRoleAsync(existingUser, ADMINISTRATION_ROLE);
                        // Put admin in selected role
                        await _UserManager.AddToRoleAsync(existingUser, SelectedUserRole);
                    }
                }
            }
            else
            {
                // Insert new user
                var newUser = new IdentityUser
                {
                    UserName = TargetUser.UserName,
                    Email = TargetUser.Email
                };
                var CreateResult = await _UserManager.CreateAsync(newUser, TargetUser.PasswordHash);
                if (!CreateResult.Succeeded)
                {
                    if (CreateResult.Errors.FirstOrDefault() != null)
                    {
                        strError =
                            CreateResult
                            .Errors
                            .FirstOrDefault()
                            .Description;
                    }
                    else
                    {
                        strError = "Create error";
                    }
                    // Keep the popup opened
                    return;
                }
                else
                {
                    // Handle Roles
                    await _UserManager.AddToRoleAsync(newUser, SelectedUserRole);
                }
            }
            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            GetUsers();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }

    public void GetUsers()
    {
        // clear any error messages
        strError = "";
        // Collection to hold users
        ColUsers = new List<IdentityUser>();
        // get users from _UserManager
        var user = _UserManager.Users.Select(x => new IdentityUser
        {
            Id = x.Id,
            UserName = x.UserName,
            Email = x.Email,
            PasswordHash = "*****"
        });
        foreach (var item in user)
        {
            ColUsers.Add(item);
        }
    }

    protected override async Task OnInitializedAsync()
    {
        // ensure there is a ADMINISTRATION_ROLE
        var RoleResult = await _RoleManager.FindByNameAsync(ADMINISTRATION_ROLE);
        if (RoleResult == null)
        {
            // Create ADMINISTRATION_ROLE Role
            await _RoleManager.CreateAsync(new IdentityRole(ADMINISTRATION_ROLE));
        }
        // Ensure a user named Admin@BlazorHelpWebsite.com is an Administrator
        var user = await _UserManager.FindByNameAsync("Admin@BlazorHelpWebsite.com");
        if (user != null)
        {
            // Is Admin@BlazorHelpWebsite.com in administrator role?
            var isAdmin = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (!isAdmin)
            {
                // Put admin in Administrator role
                await _UserManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
            }
        }
        // Get the current logged in user
        CurrentUser = (await authenticationStateTask).User;

        // Get the users
        GetUsers();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591
