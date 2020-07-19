using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class DisplayPositions
    {
        public string Position { get; set; }
        public string Description { get; set; }

        public DisplayPositions(string position, string description)
        {
            Position = position;
            Description = description;
        }

        public static object GetListDisplayPositions()
        {
            var positions = Enum.GetValues(typeof(Positions));
            var positionsToDisplay = new List<DisplayPositions>();
            foreach (var item in positions)
            {
                positionsToDisplay.Add(new DisplayPositions(item.ToString(), GetPositionDisplayName((Positions)item)));
            }
            return positionsToDisplay;
        }

        public static string GetPositionDisplayName(Positions position)
        {
            switch (position)
            {
                case Positions.Seamstress:
                    return "Швея";
                case Positions.Control:
                    return "Контролер";
                case Positions.Master:
                    return "Мастер";
                case Positions.ProductionManager:
                    return "Начальник производства";
            }
            return string.Empty;
        }

        //public static object GetPositionsDescription()
        //{
        //    return Enum.GetValues(typeof(Positions))
        //        .Cast<Enum>()
        //        .Select(value => new
        //        {
        //            (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()),
        //            typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
        //            value
        //        })
        //        .OrderBy(item => item.value)
        //        .ToList();
        //}

        //public static string GetDescription(Enum position)
        //{
        //    Type type = position.GetType();

        //    MemberInfo[] memInfo = type.GetMember(position.ToString());
        //    if (memInfo != null && memInfo.Length > 0)
        //    {
        //        object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
        //        if (attrs != null && attrs.Length > 0)
        //            return ((DescriptionAttribute)attrs[0]).Description;
        //    }

        //    return position.ToString();
        //}

    }
}
