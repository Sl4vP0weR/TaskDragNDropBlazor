function registerBlazorEvent(name, eventArgsCreator) {
    Blazor.registerCustomEventType(name.toLowerCase(), {
        createEventArgs: eventArgsCreator
    });
}
function registerDropzoneEvent(name, eventArgsCreator) {
    registerBlazorEvent(name, eventArgsCreator);
    $('.dropzone').on(name, (event, targetElement) => targetElement.dispatchEvent(new CustomEvent(name.toLowerCase(), { bubbles: true, innerEvent: event })));
}
function main() {
    // make items in dropzones draggable
    $('.dropzone').dad({
        cloneClass: "dragging",
        placeholderClass: "drop-placeholder"
    })

    // register same DAD events
    function elementArgsCreator(event) {
        return { Id: event.srcElement.id }
    }
    registerDropzoneEvent("dadDragStart", elementArgsCreator);
    registerDropzoneEvent("dadDrop", elementArgsCreator);

    // register DAD exchange event
    name = "dadDragExchange";
    registerBlazorEvent(name, elementArgsCreator);
    $('.dropzone').on(name, (event, source, target) => { target.dispatchEvent(new CustomEvent(name.toLowerCase(), { bubbles: true, innerEvent: event })); });
}
setTimeout(main, 1000);