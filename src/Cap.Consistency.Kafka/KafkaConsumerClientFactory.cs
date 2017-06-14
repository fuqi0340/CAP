﻿using Cap.Consistency.Consumer;

namespace Cap.Consistency.Kafka
{
    public class KafkaConsumerClientFactory : IConsumerClientFactory
    {
        public IConsumerClient Create(string groupId, string clientHostAddress) {
            return new KafkaConsumerClient(groupId, clientHostAddress);
        }
    }
}