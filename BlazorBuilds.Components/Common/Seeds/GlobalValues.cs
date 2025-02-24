using BlazorBuilds.Components.Common.Enums;

namespace BlazorBuilds.Components.Common.Seeds;

public class GlobalValues
{
    public const string Rating_Label_Exception_Message         = "The rating label parameter is required. It cannot be null, empty or whitespace";

    public const string Aria_Rating_Name                       = "Star";
    public const string Aria_Out_Of_Text                       = "out of";

    public const string StarRating_Class                       = "star-rating";
    public const string StarRating_Label_Class                 = $"{StarRating_Class}__label";
    public const string StarRating_Icon_Class                  = $"{StarRating_Class}__icon";
    public const string StarRating_Button_Class                = $"{StarRating_Class}__button";
    public const string StarRating_Icon_Solid_Modifier_Class   = $"{StarRating_Icon_Class}--solid";
    public const string StarRating_Icon_Outline_Modifier_Class = $"{StarRating_Icon_Class}--outline";
    public const string StarRating_Label_Hidden_Modifier_Class = $"{StarRating_Label_Class}--hidden";
    public const string StarRating_Large_Target_Modifier_Class = $"{StarRating_Class}--large-target";

    public const string Style_As_Dark  = "dark";
    public const string Style_As_Light = "light";

    public static string? GetStyleAsValue(StyleAs styleAs)

        => styleAs switch
        {
            StyleAs.OnLight => Style_As_Light,
            StyleAs.OnDark => Style_As_Dark,
            _ => null
        };

}