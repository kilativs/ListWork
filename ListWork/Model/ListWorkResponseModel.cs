using ListWork.Model.Entities;
using System;

namespace ListWork.Model
{
    internal class ListWorkResponseModel
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public string Description { get; init; }
        public Priority PriorityWork { get; init; }
        public DateTime Deadline { get; init; }
        public Condition ConditionWork { get; init; }
    }
}
