// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the settings to be used when encoding the input video into a
    /// desired output bitrate layer.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.VideoLayer")]
    public partial class VideoLayer : Layer
    {
        /// <summary>
        /// Initializes a new instance of the VideoLayer class.
        /// </summary>
        public VideoLayer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoLayer class.
        /// </summary>
        /// <param name="width">The width of the output video for this layer.
        /// The value can be absolute (in pixels) or relative (in percentage).
        /// For example 50% means the output video has half as many pixels in
        /// width as the input.</param>
        /// <param name="height">The height of the output video for this layer.
        /// The value can be absolute (in pixels) or relative (in percentage).
        /// For example 50% means the output video has half as many pixels in
        /// height as the input.</param>
        /// <param name="label">The alphanumeric label for this layer, which
        /// can be used in multiplexing different video and audio layers, or in
        /// naming the output file.</param>
        /// <param name="bitrate">The average bitrate in bits per second at
        /// which to encode the input video when generating this layer. This is
        /// a required field.</param>
        /// <param name="maxBitrate">The maximum bitrate (in bits per second),
        /// at which the VBV buffer should be assumed to refill. If not
        /// specified, defaults to the same value as bitrate.</param>
        /// <param name="bFrames">The number of B-frames to be used when
        /// encoding this layer.  If not specified, the encoder chooses an
        /// appropriate number based on the video profile and level.</param>
        /// <param name="frameRate">The frame rate (in frames per second) at
        /// which to encode this layer. The value can be in the form of M/N
        /// where M and N are integers (For example, 30000/1001), or in the
        /// form of a number (For example, 30, or 29.97). The encoder enforces
        /// constraints on allowed frame rates based on the profile and level.
        /// If it is not specified, the encoder will use the same frame rate as
        /// the input video.</param>
        /// <param name="slices">The number of slices to be used when encoding
        /// this layer. If not specified, default is zero, which means that
        /// encoder will use a single slice for each frame.</param>
        /// <param name="adaptiveBFrame">Whether or not adaptive B-frames are
        /// to be used when encoding this layer. If not specified, the encoder
        /// will turn it on whenever the video profile permits its use.</param>
        public VideoLayer(string width = default(string), string height = default(string), string label = default(string), int? bitrate = default(int?), int? maxBitrate = default(int?), int? bFrames = default(int?), string frameRate = default(string), int? slices = default(int?), bool? adaptiveBFrame = default(bool?))
            : base(width, height, label)
        {
            Bitrate = bitrate;
            MaxBitrate = maxBitrate;
            BFrames = bFrames;
            FrameRate = frameRate;
            Slices = slices;
            AdaptiveBFrame = adaptiveBFrame;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the average bitrate in bits per second at which to
        /// encode the input video when generating this layer. This is a
        /// required field.
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Gets or sets the maximum bitrate (in bits per second), at which the
        /// VBV buffer should be assumed to refill. If not specified, defaults
        /// to the same value as bitrate.
        /// </summary>
        [JsonProperty(PropertyName = "maxBitrate")]
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// Gets or sets the number of B-frames to be used when encoding this
        /// layer.  If not specified, the encoder chooses an appropriate number
        /// based on the video profile and level.
        /// </summary>
        [JsonProperty(PropertyName = "bFrames")]
        public int? BFrames { get; set; }

        /// <summary>
        /// Gets or sets the frame rate (in frames per second) at which to
        /// encode this layer. The value can be in the form of M/N where M and
        /// N are integers (For example, 30000/1001), or in the form of a
        /// number (For example, 30, or 29.97). The encoder enforces
        /// constraints on allowed frame rates based on the profile and level.
        /// If it is not specified, the encoder will use the same frame rate as
        /// the input video.
        /// </summary>
        [JsonProperty(PropertyName = "frameRate")]
        public string FrameRate { get; set; }

        /// <summary>
        /// Gets or sets the number of slices to be used when encoding this
        /// layer. If not specified, default is zero, which means that encoder
        /// will use a single slice for each frame.
        /// </summary>
        [JsonProperty(PropertyName = "slices")]
        public int? Slices { get; set; }

        /// <summary>
        /// Gets or sets whether or not adaptive B-frames are to be used when
        /// encoding this layer. If not specified, the encoder will turn it on
        /// whenever the video profile permits its use.
        /// </summary>
        [JsonProperty(PropertyName = "adaptiveBFrame")]
        public bool? AdaptiveBFrame { get; set; }

    }
}
