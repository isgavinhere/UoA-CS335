import csv

ANSWER_DIR = 'answers/'

EXAM_2015_SOLUTIONS = '2015-exam.csv'
EXAM_2015_ANSWERS   = ANSWER_DIR + '2015-exam-answers.txt'
EXAM_2014_SOLUTIONS = '2014-exam.csv'
EXAM_2014_ANSWERS   = ANSWER_DIR + '2014-exam-answers.txt'
EXAM_2013_SOLUTIONS = '2013-exam.csv'
EXAM_2013_ANSWERS   = ANSWER_DIR + '2013-exam-answers.txt'

def print_results(solutions_file, answers_file):
    solutions = csv.reader(open(solutions_file, 'r'), delimiter=',')
    answers   = open(answers_file, 'r')

    total_questions = 0
    total_answers   = 0
    total_correct   = 0

    for solution_row, answer_row in zip(solutions, answers):
        question, solution, answer = solution_row[0], solution_row[1], answer_row[0]

        if solution not in ['A','B','C','D','E']:
            continue
        total_questions += 1

        if answer == '-':
            continue
        total_answers += 1

        result = 'Incorrect'
        if solution.strip().upper() == answer:
            result = 'Correct'
            total_correct += 1

        print(question, result)

    print('########## {} ##########'.format(solutions_file.replace('.csv','')))
    print('Marks (attempted): {}/{}'.format(total_correct, total_answers))
    print('Marks (total): {}/{}'.format(total_correct, total_questions))

try:
    print_results(EXAM_2015_SOLUTIONS, EXAM_2015_ANSWERS)
except IOError:
    pass
try:
    print_results(EXAM_2014_SOLUTIONS, EXAM_2014_ANSWERS)
except IOError:
    pass
try:
    print_results(EXAM_2013_SOLUTIONS, EXAM_2013_ANSWERS)
except IOError:
    pass
