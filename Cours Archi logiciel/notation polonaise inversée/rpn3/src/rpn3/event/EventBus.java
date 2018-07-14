package rpn3.event;

import java.util.List;

public class EventBus {
    public void publish(Event event){

    }
    public <E extends Event>void Register(Class<E> eventType,Listener<E> listener){
        List<Listener> listeners=listenerPerType
    }
}
