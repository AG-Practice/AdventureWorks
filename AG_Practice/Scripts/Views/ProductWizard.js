$("#example-vertical").steps({
    headerTag: "h3",
    bodyTag: "section",
    transitionEffect: "slideLeft",
    stepsOrientation: "vertical",

    onFinished: function (event, currentIndex) {
        $("#form").submit();
    }
});


