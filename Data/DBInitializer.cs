using _24._03workapp.Models;

namespace _24._03workapp.Data;

    public static class DBInitializer
    {
        public static void Initialize(DeviceContext context)
        {

            if (context.Devices.Any()
                && context.Extras.Any()
                && context.Applications.Any())
            {
                return;   // DB has been seeded
            }

            var microphoneExtra = new Extra { Name = "Microphone" };
            var SpeakerExtra = new Extra { Name = "Speaker"};
            var LedExtra = new Extra { Name = "Led" };
            var TempExtra = new Extra { Name = "Temp"};
            var AlarmExtra = new Extra { Name = "Alarm" };

            var sender = new Application { Name = "Sender"};
            var reciver = new Application { Name = "Reciver"};

            var devices = new Device[]
            {
                new Device
                    { 
                        Name = "Hallway", 
                        Application = sender, 
                        Extras = new List<Extra>
                            {
                                LedExtra,
                                TempExtra,
                                microphoneExtra,
                                SpeakerExtra,
                                AlarmExtra
                            }
                    },
                new Device
                    { 
                        Name = "Living room", 
                        Application = sender, 
                        Extras = new List<Extra>
                            {
                                LedExtra,
                                TempExtra,
                                microphoneExtra,
                                SpeakerExtra
                            }
                    },
                new Device
                    { 
                        Name="Upstairs", 
                        Application = reciver, 
                        Extras = new List<Extra>
                            {
                                SpeakerExtra
                            }
                        }
            };

            context.Devices.AddRange(devices);
            context.SaveChanges();
        }
    }
