﻿using System;

namespace EventStore.Core.TransactionLogV2.Tests.Fakes {
	public class FakeTfReader : ITransactionFileReader {
		public void Reposition(long position) {
			throw new NotImplementedException();
		}

		public SeqReadResult TryReadNext() {
			throw new NotImplementedException();
		}

		public SeqReadResult TryReadPrev() {
			throw new NotImplementedException();
		}

		public RecordReadResult TryReadAt(long position) {
			throw new NotImplementedException();
		}

		public bool ExistsAt(long position) {
			return true;
		}
	}
}