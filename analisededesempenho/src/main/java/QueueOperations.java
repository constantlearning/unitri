interface QueueOperations {

    fun rateOfArrival(quantity: Long?, unit: Unit): Double?  // Lambda
    fun serviceRate(quantity: Long?, unit: Unit): Double?  // Mu
    fun probabilyOfServerBeingBusy(lambda: Double?, mu: Double?): Double?  // P
    fun averageTimeOfPermanenceInTheSystem(lambda: Double?, mu: Double?): Double?  // W
    fun averageTimeOfWaitingInTheSystem(lambda: Double?, mu: Double?): Double?  // Wq
    fun averageOfClientsInTheSystem(lambda: Double?, mu: Double?): Double?  // L
    fun averageOfWaitingInTheQueue(lambda: Double?, mu: Double?): Double?  // Lq
    fun probabilityToHaveNClientsInQueue(lambda: Double?, mu: Double?, quantity: Int?): Double?  // PI(n)
    fun probabilityOfNIsGreatterThenK(lambda: Double?, mu: Double?, quantity: Int?): Double?  // P(N > K)
}
