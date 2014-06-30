/// Copyright (C) 2012-2014 Soomla Inc.
///
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///      http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.

using UnityEngine;
using System;

namespace Soomla
{
	public class RewardStorage
	{

		protected const string TAG = "SOOMLA RewardStorage"; // used for Log error messages

		static RewardStorage _instance = null;
		static RewardStorage instance {
			get {
				if(_instance == null) {
					#if UNITY_ANDROID && !UNITY_EDITOR
					_instance = new RewardStorageAndroid();
					#elif UNITY_IOS && !UNITY_EDITOR
					_instance = new RewardStorageIOS();
					#else
					_instance = new RewardStorage();
					#endif
				}
				return _instance;
			}
		}
			

		public static void SetRewardStatus(Reward reward, boolean give) {
			SetRewardStatus(reward, give, true);
		}

		public static void SetRewardStatus(Reward reward, boolean give, boolean notify) {
			_instance._setRewardStatus(reward, give, notify);
		}

		public static boolean IsRewardGiven(Reward reward) {
			return _instance._isRewardGiven(reward);
		}

		/// <summary>
		/// Retrieves the index of the last reward given in a sequence of rewards.
		/// </summary>
		public static int GetLastSeqIdxGiven(Reward reward) {
			return _instance._getLastSeqIdxGiven(reward);
		}

		public static void SetLastSeqIdxGiven(Reward reward, int idx) {
			_instance._setLastSeqIdxGiven(reward, idx);
		}




		virtual protected void _setRewardStatus(Reward reward, boolean give, boolean notify) {
			// TODO: WIE
		}

		virtual protected bool _isRewardGiven(Reward reward) {
			// TODO: WIE
		}

		virtual protected int _getLastSeqIdxGiven(Reward reward) {
			// TODO: WIE
		}

		virtual protected void _setLastSeqIdxGiven(Reward reward, int idx) {
			// TODO: WIE
		}
	}
}

