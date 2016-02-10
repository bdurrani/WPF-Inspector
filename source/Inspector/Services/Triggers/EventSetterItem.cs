using System.Windows;

namespace ChristianMoser.WpfInspector.Services.Triggers
{
    /// <summary>
    /// Abstraction model of a <see cref="EventSetter"/>
    /// </summary>
    public class EventSetterItem
    {
        public EventSetterItem(string eventName, string handler)
        {
            EventName = eventName;
            Handler = handler;
        }

        public string EventName { get; private set; }
        public string Handler { get; private set; }
    }
}
