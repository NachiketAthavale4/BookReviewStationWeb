namespace BookReviewStation.Web.Helpers
{
    using System;
    using System.Configuration;
    using System.Web.Mvc;

    public static class ViewHelpers
    {
        public static MvcHtmlString SafeValueDisplay(this HtmlHelper html, string fieldName, string valueToBeDisplayed)
        {
            if (string.IsNullOrWhiteSpace(valueToBeDisplayed))
            {
                return new MvcHtmlString(string.Empty);
            }

            TagBuilder fieldStrTag = new TagBuilder("b");
            fieldStrTag.SetInnerText($"{fieldName}{Constants.ColonString}");

            TagBuilder fieldValTag = new TagBuilder("span");
            fieldValTag.SetInnerText($"{Constants.SpaceString}{valueToBeDisplayed}");

            TagBuilder h3safeTag = new TagBuilder("h6");
            h3safeTag.InnerHtml += $"{fieldStrTag.ToString()}{fieldValTag.ToString()}";

            return new MvcHtmlString(h3safeTag.ToString());
        }

        public static MvcHtmlString SafeValueIntegerDisplay(this HtmlHelper html, string fieldName, int? valueToBeDisplayed)
        {
            if (!valueToBeDisplayed.HasValue)
            {
                return new MvcHtmlString(string.Empty);
            }

            TagBuilder fieldStrTag = new TagBuilder("b");
            fieldStrTag.SetInnerText($"{fieldName}{Constants.ColonString}");

            TagBuilder fieldValTag = new TagBuilder("span");
            fieldValTag.SetInnerText($"{Constants.SpaceString}{valueToBeDisplayed.Value}");

            TagBuilder h3safeTag = new TagBuilder("h6");
            h3safeTag.InnerHtml += $"{fieldStrTag.ToString()}{fieldValTag.ToString()}";

            return new MvcHtmlString(h3safeTag.ToString());
        }

        public static MvcHtmlString SafeValueDimensionsDisplay(
            this HtmlHelper html, 
            string fieldName, 
            int? height, 
            int? width, 
            int? length)
        {
            if (!height.HasValue || !length.HasValue || !width.HasValue)
            {
                return new MvcHtmlString(string.Empty);
            }

            TagBuilder fieldStrTag = new TagBuilder("b");
            fieldStrTag.SetInnerText($"{fieldName}{Constants.ColonString}");

            TagBuilder fieldValTag = new TagBuilder("span");
            fieldValTag.SetInnerText($"{Constants.SpaceString}{height.Value} x {length.Value} x {width.Value} cm");

            TagBuilder h3safeTag = new TagBuilder("h6");
            h3safeTag.InnerHtml += $"{fieldStrTag.ToString()}{fieldValTag.ToString()}";

            return new MvcHtmlString(h3safeTag.ToString());
        }

        public static MvcHtmlString GetStarRatingHtml(this HtmlHelper html, double starRating)
        {
            var maximumStarRating = Convert.ToInt32(ConfigurationManager.AppSettings["StarRatingMaximum"]);
            var starInteger = Math.Floor(starRating);

            TagBuilder starTextTag = new TagBuilder("span");
            starTextTag.AddCssClass("mx-2");
            starTextTag.SetInnerText($"{starRating} out of {maximumStarRating} Stars");

            TagBuilder divTagBuilder = null;

            switch (starInteger)
            {
                case 1: divTagBuilder = GetStarIconStr(1);
                        break;
                case 2: divTagBuilder = GetStarIconStr(2);
                        break;
                case 3: divTagBuilder = GetStarIconStr(3);
                        break;
                case 4: divTagBuilder = GetStarIconStr(4);
                        break;
                case 5: divTagBuilder = GetStarIconStr(5);
                        break;
                default: divTagBuilder = GetStarIconStr(0);
                         break;
            }

            if (divTagBuilder == null)
            {
                return new MvcHtmlString(string.Empty);
            }

            if (starInteger == 5)
            {
                divTagBuilder.InnerHtml += starTextTag;
                return new MvcHtmlString(divTagBuilder.ToString());
            }

            double decimalStarRating = (starRating % 1) % Convert.ToDouble(maximumStarRating);
            var postDecimalStarRating = Math.Round(decimalStarRating, 2);

            if (postDecimalStarRating != 0.00)
            {
                divTagBuilder.InnerHtml += GetHalfStarIconStr();

                for (int i = 0; i < maximumStarRating - starInteger - 1; i++)
                {
                    divTagBuilder.InnerHtml += GetEmptyStarIconStr();
                }
            }
            else
            {
                for(int i = 0; i < maximumStarRating - starInteger; i++)
                {
                    divTagBuilder.InnerHtml += GetEmptyStarIconStr();
                }
            }

            divTagBuilder.InnerHtml += starTextTag;
            return new MvcHtmlString(divTagBuilder.ToString());
        }

        public static MvcHtmlString GetStarRatingHtmlWithNoText(this HtmlHelper html, double starRating)
        {
            var maximumStarRating = Convert.ToInt32(ConfigurationManager.AppSettings["StarRatingMaximum"]);
            var starInteger = Math.Floor(starRating);

            TagBuilder starTextTag = new TagBuilder("span");
            starTextTag.AddCssClass("mx-2");
            starTextTag.SetInnerText($"{starRating}/{maximumStarRating}");

            TagBuilder divTagBuilder = null;

            switch (starInteger)
            {
                case 1:
                    divTagBuilder = GetStarIconStr(1);
                    break;
                case 2:
                    divTagBuilder = GetStarIconStr(2);
                    break;
                case 3:
                    divTagBuilder = GetStarIconStr(3);
                    break;
                case 4:
                    divTagBuilder = GetStarIconStr(4);
                    break;
                case 5:
                    divTagBuilder = GetStarIconStr(5);
                    break;
                default:
                    divTagBuilder = GetStarIconStr(0);
                    break;
            }

            if (divTagBuilder == null)
            {
                return new MvcHtmlString(string.Empty);
            }

            if (starInteger == 5)
            {
                divTagBuilder.InnerHtml += starTextTag;
                return new MvcHtmlString(divTagBuilder.ToString());
            }

            double decimalStarRating = (starRating % 1) % Convert.ToDouble(maximumStarRating);
            var postDecimalStarRating = Math.Round(decimalStarRating, 2);

            if (postDecimalStarRating != 0.00)
            {
                divTagBuilder.InnerHtml += GetHalfStarIconStr();

                for (int i = 0; i < maximumStarRating - starInteger - 1; i++)
                {
                    divTagBuilder.InnerHtml += GetEmptyStarIconStr();
                }
            }
            else
            {
                for (int i = 0; i < maximumStarRating - starInteger; i++)
                {
                    divTagBuilder.InnerHtml += GetEmptyStarIconStr();
                }
            }

            divTagBuilder.InnerHtml += starTextTag;
            return new MvcHtmlString(divTagBuilder.ToString());
        }

        private static TagBuilder GetStarIconStr(int numberOfStars)
        {
            TagBuilder divTagBuilder = new TagBuilder("div");

            for (int i = 0; i < numberOfStars; i++)
            {
                TagBuilder starSpanTag = new TagBuilder("span");
                starSpanTag.AddCssClass("fa");
                starSpanTag.AddCssClass("fa-star");
                starSpanTag.AddCssClass("checked");
                divTagBuilder.InnerHtml += starSpanTag;
            }

            return divTagBuilder;
        }

        private static TagBuilder GetHalfStarIconStr()
        {
            TagBuilder starSpanTag = new TagBuilder("span");
            starSpanTag.AddCssClass("fa");
            starSpanTag.AddCssClass("fa-star-half-full");
            starSpanTag.AddCssClass("checked");
            return starSpanTag;
        }

        private static TagBuilder GetEmptyStarIconStr()
        {
            TagBuilder emptyStarSpanTag = new TagBuilder("span");
            emptyStarSpanTag.AddCssClass("fa");
            emptyStarSpanTag.AddCssClass("fa-star-o");
            emptyStarSpanTag.AddCssClass("checked");
            return emptyStarSpanTag;
        }
    }
}