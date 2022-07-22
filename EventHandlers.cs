namespace TaskDragNDropBlazor;

[EventHandler("ondaddragstart", typeof(ElementEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
[EventHandler("ondaddrop", typeof(ElementEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
[EventHandler("ondaddragexchange", typeof(ElementEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
public static class EventHandlers { }