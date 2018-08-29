using Abp.Application.Navigation;
using Abp.Localization;

namespace Storemey.Web.Navigation
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class StoremeyNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        AppPageNames.Events,
                        new LocalizableString("Events", StoremeyConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-calendar-check-o"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        AppPageNames.About,
                        new LocalizableString("About", StoremeyConsts.LocalizationSourceName),
                        url: "#/about",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        AppPageNames.Users,
                        new LocalizableString("Users", StoremeyConsts.LocalizationSourceName),
                        url: "#/users",
                        icon: "fa fa-info"
                        )
                );
        }
    }
}
