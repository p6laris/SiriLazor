/**
 * SiriWave namespace for managing SiriWave instances.
 * @namespace
 */
window.siriWave = {

    /**
     * Initializes a SiriWave instance with iOS style.
     * @function
     * @param {Object} options - Options for configuring the SiriWave instance.
     * @returns {number} - The index of the created SiriWave instance in the global array.
     */
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

    /**
     * Initializes a SiriWave instance with iOS 9 style.
     * @function
     * @param {Object} options - Options for configuring the SiriWave instance.
     * @returns {number} - The index of the created SiriWave instance in the global array.
     */
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

    /**
     * Starts the SiriWave animation for the specified instance.
     * @function
     * @param {number} instance - The index of the SiriWave instance to start.
     */
    start: function (instance) {
        if (window.sw[instance] !== null) {
            window.sw[instance].start();
        }
    },

    /**
     * Stops the SiriWave animation for the specified instance.
     * @function
     * @param {number} instance - The index of the SiriWave instance to stop.
     */
    stop: function (instance) {
        if (window.sw[instance] != null) {
            window.sw[instance].stop();
        }
    },

    /**
     * Sets the speed of the SiriWave animation for the specified instance.
     * @function
     * @param {number} newValue - The new speed value.
     * @param {number} instance - The index of the SiriWave instance to update.
     */
    setSpeed: function (newValue, instance) {
        if (window.sw[instance] !== null) {
            window.sw[instance].speed = newValue;
        }
    },

    /**
     * Sets the amplitude of the SiriWave animation for the specified instance.
     * @function
     * @param {number} value - The new amplitude value.
     * @param {number} instance - The index of the SiriWave instance to update.
     */
    setAmplitude: function (value, instance) {
        if (window.sw[instance] !== null) {
            window.sw[instance].amplitude = value;
        }
    },

    /**
     * Disposes the SiriWave instance, freeing associated resources.
     * @function
     * @param {number} instance - The index of the SiriWave instance to dispose.
     */
    dispose: function (instance) {
        if (window.sw[instance] !== null) {
            window.sw[instance].dispose();
            window.sw[instance] = null;
        }
    },

    /**
     * Disposes all SiriWave instances, freeing associated resources.
     * @function
     */
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
