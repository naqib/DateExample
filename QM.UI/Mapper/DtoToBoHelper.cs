using QM.Domain.Bo;
using QM.Domain.Model;
using QM.UI.Models;
using System;

namespace QM.UI.Mapper
{
    public class DtoToBoHelper
    {
        /// <summary>
        /// This is a mapper helper which takes input of DateDto object and convert it 
        /// to DateBo object, in order to not use DateTime functions I have used string split/substring
        /// </summary>
        /// <param name="dto">DateDto</param>
        /// <returns>DateBo</returns>
        public static DateBo DateDtoToBo(DateDto dto){
            var day = Convert.ToInt32(dto.FirstDate.ToString().Split('/')[0]);
            var month = Convert.ToInt32(dto.FirstDate.ToString().Split('/')[1]);
            var year = Convert.ToInt32(dto.FirstDate.ToString().Split('/')[2].ToString()
                                                                             .Substring(0, 4));

            var firstDate = new Date(day, month, year);

            day = Convert.ToInt32(dto.SecondDate.ToString().Split('/')[0]);
            month = Convert.ToInt32(dto.SecondDate.ToString().Split('/')[1]);
            year = Convert.ToInt32(dto.SecondDate.ToString().Split('/')[2].ToString()
                                                                             .Substring(0, 4));

            var secondDate = new Date(day, month, year);

            return new DateBo { FirstDate = firstDate, SecondDate = secondDate };
        }
    }
}
