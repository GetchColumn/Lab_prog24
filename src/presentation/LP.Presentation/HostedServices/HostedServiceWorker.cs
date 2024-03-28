using LP.Application.Common.Interfaces.Services;
using LP.Domain.Entities;
using LP.Domain.Entities.Base;
using LP.Presentation.Utilities;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Presentation.HostedServices
{
    public class HostedServiceWorker:IHostedService
    {
        private readonly IStudentService _studentService;
        private readonly IHeadOfDService _headofdService;
        private readonly IEducatorService _educatorService;

        public HostedServiceWorker(IStudentService studentService, IEducatorService educatorService, IHeadOfDService headofdService)
        {
            _studentService = studentService;
            _educatorService = educatorService;
            _headofdService = headofdService;
        }
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await BuildMenu();
        }


        private async Task BuildMenu()
        {
            List<Person> DataList = new List<Person>();
            while (true)
            {
                Console.WriteLine("Выберите пункт меню для начала:");
                Console.WriteLine("1 - Добавить объект");
                Console.WriteLine("2 - Получить объект");
                Console.WriteLine("3 - Сохранить список");
                Console.WriteLine("4 - Получить список");
                var key = Console.ReadKey();
                Console.Clear();
                switch (key.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Выберите тип объекта: ");
                        Console.WriteLine("1 - студент");
                        Console.WriteLine("2 - преподаватель");
                        Console.WriteLine("3 - заведующий кафедрой");
                        var choice = Console.ReadKey();
                        Console.Clear();
                        switch (choice.KeyChar)
                        {
                              case '1':
                                Console.WriteLine("Укажите имя объекта: ");
                                var newStud = StudentUtilities.Create(Console.ReadLine() ?? "");
                                Console.WriteLine($"Создан студент Id: {newStud.Id}, Name= {newStud.Name}");
                                _studentService.Add(newStud);
                                DataList.Add(newStud);
                                break;

                              case '2':
                                Console.WriteLine("Укажите имя объекта: ");
                                var newEduc = EducatorUtilities.Create(Console.ReadLine() ?? "");
                                Console.WriteLine($"Создан студент Id: {newEduc.Id}, Name= {newEduc.Name}");
                                _educatorService.Add(newEduc);
                                DataList.Add(newEduc);
                                break;

                              case '3':
                                Console.WriteLine("Укажите имя объекта: ");
                                var newHead = HeadOfDUtilities.Create(Console.ReadLine() ?? "");
                                Console.WriteLine($"Создан студент Id: {newHead.Id}, Name= {newHead.Name}");
                                _headofdService.Add(newHead);
                                DataList.Add(newHead);
                                break;

                        }
                        //var rectStr = _rectangleService.SerializeToString(newRect);
                        //Console.WriteLine(rectStr);
                        //await _rectangleService.SerializeToFile(newRect, "rectangle.txt");
                        //var getRect = _rectangleService.DeserializeFromString(rectStr);
                        break;

                    case '2':
                        Console.Clear();
                        Console.WriteLine("Выберите тип объекта: ");
                        Console.WriteLine("1 - студент");
                        Console.WriteLine("2 - преподаватель");
                        Console.WriteLine("3 - заведующий кафедрой");
                        switch (Console.ReadKey().KeyChar)
                        {
                            case '1':
                                Console.WriteLine("Пожалуйста, введите имя объекта:");
                                var studResultList = _studentService.GetList(Console.ReadLine() ?? "");
                                studResultList.ForEach(student => Console.WriteLine($"Студент - {student.Name}"));
                                if (studResultList.Count > 0)
                                {
                                    _studentService.GetById(studResultList[0].Id);
                                }
                                break;
                            case '2':
                                Console.WriteLine("Пожалуйста, введите имя объекта:");
                                var educResultList = _educatorService.GetList(Console.ReadLine() ?? "");
                                educResultList.ForEach(educator => Console.WriteLine($"Преподаватель - {educator.Name}"));
                                if (educResultList.Count > 0)
                                {
                                    _educatorService.GetById(educResultList[0].Id);
                                }
                                break;
                            case '3':
                                Console.WriteLine("Пожалуйста, введите имя объекта:");
                                var headResultList = _headofdService.GetList(Console.ReadLine() ?? "");
                                headResultList.ForEach(headofd => Console.WriteLine($"Преподаватель - {headofd.Name}"));
                                if (headResultList.Count > 0)
                                {
                                    _headofdService.GetById(headResultList[0].Id);
                                }
                                break;
                        }

                        break;
/*
                    case '3':
                        foreach (var persn in DataList)
                        {
                            if (persn is Student)
                            {
                                await _studentService.SerializeToFile(persn, "dataList.txt");
                            }

                        }
                        await _studentService.SerializeToFile(DataList, "dataList.txt");
                        await _rectangleService.SerializeToFile(DataList, "dataList.txt");

                        break;
                    case '4':
                        DataList = await _rectangleService.
                            DeserializeFromFile("dataList.txt") ?? new List<Rectangle>();
                        DataList.ForEach(rectangle => Console.WriteLine(rectangle.Name));
                        break;*/
                    default:
                        break;

                }
            }
        }
        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Task.Delay(1);
        }
    }
}
