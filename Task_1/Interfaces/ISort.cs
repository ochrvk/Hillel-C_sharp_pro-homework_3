﻿namespace Task_1.Interfaces
{
    public interface ISort
    {
        public void SortAsc();

        public void SortDesc();

        public void SortByParam(bool isAsc);
    }
}
