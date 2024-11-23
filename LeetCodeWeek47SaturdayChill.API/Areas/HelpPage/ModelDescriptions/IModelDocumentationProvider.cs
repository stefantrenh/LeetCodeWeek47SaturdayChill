using System;
using System.Reflection;

namespace LeetCodeWeek47SaturdayChill.API.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}