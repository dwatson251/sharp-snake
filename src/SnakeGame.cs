using Runner = Engine.Runner;
using Engine.Application.Service;
using Container = Engine.Application.Service.Container;
using SnakeEntity = Snake.Domain.Entity.Snake;
using Snake.Domain.Entity;
using System;
using System.Collections.Generic;

public class SnakeGame
{
    private Container _container;
    private Runner _runner;

    public static void Main()
    {
        Container _container = new Container();
        _container.Register<EventBus, EventBus>();
        _container.Register<Runner, Runner>();

        Runner _runner = _container.Resolve<Runner>();

        // Init Object Data

        // Init control listener

        // Init Renderer

        SnakeEntity snake = new SnakeEntity();

        while (true)
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            snake.Move();
            foreach (Cell cell in snake.GetCells())
            {
                List<object> coordinates = new List<object>{
                    cell.GetX(),
                    cell.GetY(),
                    (cell.IsDigesting()) ? "Digesting" : "",
                    (cell.WillDigestSoon()) ? "Digesting Soon" : "",
                };
                Console.WriteLine(string.Join(", ", coordinates));
            }
        }
    }
}