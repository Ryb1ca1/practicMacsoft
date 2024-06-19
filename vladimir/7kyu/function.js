function hasSurvived(attackers, defenders) {
    let attackerSurvivors = 0;
    let defenderSurvivors = 0;
    let attackerStrength = 0;
    let defenderStrength = 0;

    let maxLength = Math.max(attackers.length, defenders.length);

    for (let i = 0; i < maxLength; i++) {
        let attacker = attackers[i] || 0;
        let defender = defenders[i] || 0;

        attackerStrength += attacker;
        defenderStrength += defender;

        if (attacker > defender) {
            attackerSurvivors++;
        } else if (defender > attacker) {
            defenderSurvivors++;
        }
    }

    if (defenderSurvivors > attackerSurvivors) {
        return true;
    } else if (attackerSurvivors > defenderSurvivors) {
        return false;
    } else {
        return defenderStrength >= attackerStrength;
    }
}