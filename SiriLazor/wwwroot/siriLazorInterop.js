window.sw = [];

window.siriWave = {
    initIOS: function (options) {
        let instance = new SiriWave({
            container: options.container,
            style: 'ios',
            ratio: options.ratio || 1.0,
            speed: options.speed || 0.2,
            amplitude: options.amplitude || 1.0,
            frequency: options.frequency || 6.0,
            color: options.color || '#ffffff',
            cover: options.cover || true,
            width: options.width || 640.0,
            height: options.height || 200.0,
            autostart: options.autostart || true,
            pixelDepth: options.pixelDepth || 0.02,
            lerpSpeed: options.lerpSpeed || 0.01


        });

        window.sw.push(instance);

        // Get the index of the pushed instance
        const instanceIndex = window.sw.indexOf(instance);

        return instanceIndex;

    },
    initIOS9: function (options) {
        let instance = new SiriWave({
            container: options.container,
            style: 'ios9',
            ratio: options.ratio || 1.0,
            speed: options.speed || 0.2,
            amplitude: options.amplitude || 1.0,
            cover: options.cover || true,
            width: options.width || 640.0,
            height: options.height || 200.0,
            autostart: options.autostart || true,
            pixelDepth: options.pixelDepth || 0.02,
            lerpSpeed: options.lerpSpeed || 0.01,
            ranges: options.iOS9Ranges,
            globalCompositeOperation: options.globalCompositeOperation || 'lighter',
            curveDefinition: options.definitions

        });

        window.sw.push(instance);

        // Get the index of the pushed instance
        const instanceIndex = window.sw.indexOf(instance);

        return instanceIndex;


    },

    start: function (instance) {
        if (window.sw[instance] !== null) {
            window.sw[instance].start();
        }
    },

    stop: function (instance) {
        if (window.sw[instance] != null) {
            window.sw[instance].stop();
        }
    },

    setSpeed: function (newValue, instance) {
        if (window.sw[instance] !== null) {
            window.sw[instance].speed = newValue
        }
    },

    setAmplitude: function (value, instance) {
        if (window.sw[instance] !== null) {
            window.sw[instance].amplitude = value;
        }
    },

    dispose: function (instance) {
        if (window.sw[instance] !== null) {
            window.sw[instance].dispose();
            window.sw[instance] = null;
        }
    },

    disposeAll: function () {
        if (window.sw !== null) {
            for (var i = 0; i < sw.length; i++) {
                window.sw[i].dispose();
                window.sw[i] = null;
            }
        }
        window.sw = null;
    }
};