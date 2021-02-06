using Microsoft.EntityFrameworkCore;
using ModelingObject;
using ModelingObject.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using WpfDiagram.Core.Mvvm;

namespace WpfDiagramViewer.ViewModels
{
    public class ViewerMainViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ObservableCollection<string> Equipments { get; private set; } = new ObservableCollection<string>();
        public ObservableCollection<ShapeViewModelBase> Shapes { get; private set; } = new ObservableCollection<ShapeViewModelBase>();

        public DelegateCommand GoSqlCommand { get; private set; }

        public ViewerMainViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Message = "Viewer Module.";
            GoSqlCommand = new DelegateCommand(DoSqlTest);

            Equipments.Clear();

            List<string> equipments = new List<string>();
            for (int i = 0; i < 200; i++)
            {
                equipments.Add("Inlet");
                equipments.Add("Outlet");
                equipments.Add("Valve");
                equipments.Add("Pipe");
            }

            Equipments.AddRange(equipments);

            List<ShapeViewModelBase> shapes = new List<ShapeViewModelBase>();
            for (int i = 0; i < 30; i++)
            {
                shapes.Add(new InletViewModel()
                {
                    X = (i % 8) * 40 + 5,
                    Y = (int)(i / 8) * 40 + 5,
                    Width = 64,
                    Height = 64,
                    Angle = 0
                });
            }
            for (int i = 0; i < 5; i++)
            {
                shapes.Add(new PipeViewModel()
                {
                    X = (i % 8) * 40 + 5,
                    Y = (int)(i / 8) * 40 + 5 +300,
                    Width = 64,
                    Height = 64,
                    Angle = 0
                });
            }

            Shapes.AddRange(shapes);
        }

        private void DoSqlTest()
        {
            using (var db = new ModelingObjectContext())
            {
                System.Diagnostics.Debug.WriteLine($"Equipments count: {db.Equipments.Count()}");
                System.Diagnostics.Debug.WriteLine($"EquipmentConnectors count: {db.EquipmentConnectors.Count()}");
                System.Diagnostics.Debug.WriteLine($"MappingInfos count: {db.MappingLocations.Count()}");

                Inlet e0 = new Inlet()
                {
                    Name = "Inlet0",
                    MappingLocation = new MappingLocation()
                    {
                        X = 10,
                        Y = 10,
                        Width = 35,
                        Height = 35
                    }
                };

                Pipe e1 = new Pipe()
                {
                    Name = "Pipe1",
                    MappingLocation = new MappingLocation()
                    {
                        X = 75,
                        Y = 10,
                        Width = 20,
                        Height = 20
                    }
                };

                EquipmentConnector c0 = new EquipmentConnector()
                {
                    UpstreamEquipment = e0,
                    DownstreamEquipment = e1
                };

                db.Add(e0);
                db.Add(e1);
                db.Add(c0);
                db.SaveChanges();

                var equips = db.Equipments.Include(e => e.MappingLocation).Include(e => e.ShapeColor);

                foreach (var eq in equips)
                {
                    System.Diagnostics.Debug.WriteLine($"Equipments : {eq.EquipmentId}");
                    System.Diagnostics.Debug.WriteLine($"Equipments : {eq.Name}");
                    System.Diagnostics.Debug.WriteLine($"Equipments X: {eq.MappingLocation.X}");
                }

                var connectors = db.EquipmentConnectors.Include(c => c.UpstreamEquipment).Include(c => c.DownstreamEquipment);
                foreach (var c in connectors)
                {
                    System.Diagnostics.Debug.WriteLine($"Connector up : {c.UpstreamEquipment?.EquipmentId}");
                    System.Diagnostics.Debug.WriteLine($"Connector down : {c.DownstreamEquipment?.EquipmentId}");
                }
            }
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);
        }
    }
}
