using cleandemo.Application.Common.Interfaces;
using System;

namespace cleandemo.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
