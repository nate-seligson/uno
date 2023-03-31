﻿#if !(__ANDROID__ || __IOS__ || __MACOS__)
#nullable enable

using System;
using System.Collections.Generic;
using System.Text;
using Uno.Foundation.Extensibility;
using Uno.Foundation.Logging;
using Windows.Foundation;
using Uno.Media.Playback;

namespace Windows.Media.Playback
{
	public partial class MediaPlayer
	{
		void RaiseBufferingEnded()
			=> BufferingEnded?.Invoke(this, new object());

		void RaiseBufferingStarted()
			=> BufferingStarted?.Invoke(this, new object());

		void RaiseCurrentStateChanged()
			=> CurrentStateChanged?.Invoke(this, new object());

		void RaiseIsMutedChanged()
			=> IsMutedChanged?.Invoke(this, new object());

		void RaiseMediaEnded()
			=> MediaEnded?.Invoke(this, new object());

		void RaiseMediaFailed(MediaPlayerError error, string errorMessage, Exception extendedErrorCode)
			=> MediaFailed?.Invoke(this, new MediaPlayerFailedEventArgs(error, errorMessage, extendedErrorCode));

		void RaiseMediaOpened()
			=> MediaOpened?.Invoke(this, new object());

		void RaisePlaybackMediaMarkerReached(PlaybackMediaMarker playbackMediaMarker)
			=> PlaybackMediaMarkerReached?.Invoke(this, new PlaybackMediaMarkerReachedEventArgs(playbackMediaMarker));

		void RaiseMediaPlayerRateChanged(double newRate)
			=> MediaPlayerRateChanged?.Invoke(this, new(newRate));

		void RaiseSeekCompleted()
			=> SeekCompleted?.Invoke(this, new object());

		void RaiseSourceChanged()
			=> SourceChanged?.Invoke(this, new object());

		void RaiseSubtitleFrameChanged()
			=> SubtitleFrameChanged?.Invoke(this, new object());

		void RaiseVideoFrameAvailable()
			=> VideoFrameAvailable?.Invoke(this, new object());

		void RaiseVideoRatioChanged(double videoRatio)
			=> VideoRatioChanged?.Invoke(this, videoRatio);

		void RaiseVolumeChanged()
			=> VolumeChanged?.Invoke(this, null);

		class MediaPlayerEvents : IMediaPlayerEventsExtension
		{
			private MediaPlayer _owner;

			public MediaPlayerEvents(MediaPlayer owner)
			{
				_owner = owner;
			}

			void IMediaPlayerEventsExtension.RaiseBufferingEnded()
				=> _owner.RaiseBufferingEnded();
			void IMediaPlayerEventsExtension.RaiseBufferingStarted()
				=> _owner.RaiseBufferingStarted();
			void IMediaPlayerEventsExtension.RaiseCurrentStateChanged()
				=> _owner.RaiseCurrentStateChanged();
			void IMediaPlayerEventsExtension.RaiseIsMutedChanged()
				=> _owner.RaiseIsMutedChanged();
			void IMediaPlayerEventsExtension.RaiseMediaEnded()
				=> _owner.RaiseMediaEnded();
			void IMediaPlayerEventsExtension.RaiseMediaFailed(MediaPlayerError error, string errorMessage, Exception extendedErrorCode)
				=> _owner.RaiseMediaFailed(error, errorMessage, extendedErrorCode);
			void IMediaPlayerEventsExtension.RaiseMediaOpened()
				=> _owner.RaiseMediaOpened();
			void IMediaPlayerEventsExtension.RaisePlaybackMediaMarkerReached(PlaybackMediaMarker playbackMediaMarker)
				=> _owner.RaisePlaybackMediaMarkerReached(playbackMediaMarker);
			void IMediaPlayerEventsExtension.RaiseMediaPlayerRateChanged(double newRate)
				=> _owner.RaiseMediaPlayerRateChanged(newRate);
			void IMediaPlayerEventsExtension.RaiseSeekCompleted()
				=> _owner.RaiseSeekCompleted();
			void IMediaPlayerEventsExtension.RaiseSourceChanged()
				=> _owner.RaiseSourceChanged();
			void IMediaPlayerEventsExtension.RaiseSubtitleFrameChanged()
				=> _owner.RaiseSubtitleFrameChanged();
			void IMediaPlayerEventsExtension.RaiseVideoFrameAvailable()
				=> _owner.RaiseVideoFrameAvailable();
			void IMediaPlayerEventsExtension.RaiseVideoRatioChanged(double videoRatio)
				=> _owner.RaiseVideoRatioChanged(videoRatio);
			void IMediaPlayerEventsExtension.RaiseVolumeChanged()
				=> _owner.RaiseVolumeChanged();
		}
	}
}
#endif
