namespace Main_Program
{
    public interface IEnemyCreator
    {
        DifficultyLevel HowDifficult(string enemy);
        Enemy StartUp();
        Enemy WhatType();
    }
}